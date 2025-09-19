using System.IO;
using System.Text;

namespace HollowKnightSilkSong;

[Harmony]
public class TestResolutions : MonoBehaviour
{
    private static bool _testRunning = false;
    private static int _currentResolutionIndex = 0;
    private static int _currentFovIndex = 0;
    private static readonly float[] TestFovValues = [0f, 5f, 10f, 15f, 20f, 25f];
    private static readonly List<TestResult> TestResults = [];
    
    private class TestResult
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string AspectName { get; set; }
        public float AspectRatio { get; set; }
        public float FOV { get; set; }
        public bool EdgesVisible { get; set; }
        public DateTime Timestamp { get; set; }
    }
    
   
    public void Update()
    {
        // F9: Start automated testing
        if (Input.GetKeyDown(KeyCode.F9) && !_testRunning)
        {
            StartTesting();
        }

        // F10: Stop testing and export results
        if (Input.GetKeyDown(KeyCode.F10) && _testRunning)
        {
            StopTesting();
        }

        // Only process Y/N inputs during active testing
        if (!_testRunning) return;

        // Y: Mark edges visible and advance
        if (Input.GetKeyDown(KeyCode.Y))
        {
            RecordResult(true);
            NextTest();
        }

        // N: Mark edges not visible and advance
        if (Input.GetKeyDown(KeyCode.N))
        {
            RecordResult(false);
            NextTest();
        }

        // ESC: Emergency stop
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Plugin.Log.LogWarning("[TEST] Emergency stop - test cancelled");
            _testRunning = false;
        }
    }

    private static void StartTesting()
    {
        _testRunning = true;
        _currentResolutionIndex = 0;
        _currentFovIndex = 0;
        TestResults.Clear();
        
        Plugin.Log.LogWarning("========================================");
        Plugin.Log.LogWarning("[TEST] AUTOMATED TESTING STARTED");
        Plugin.Log.LogWarning("[TEST] Press Y for edges visible, N for not visible");
        Plugin.Log.LogWarning("[TEST] Press F10 to finish and export results");
        Plugin.Log.LogWarning("========================================");
        
        SetupNextTest();
    }

    private static void StopTesting()
    {
        _testRunning = false;
        
        Plugin.Log.LogWarning("========================================");
        Plugin.Log.LogWarning("[TEST] TESTING COMPLETE");
        Plugin.Log.LogWarning($"[TEST] Total tests recorded: {TestResults.Count}");
        Plugin.Log.LogWarning("========================================");
        
        ExportResults();
    }

    private static void SetupNextTest()
    {
        if (_currentResolutionIndex >= Resolutions.Length)
        {
            Plugin.Log.LogWarning("[TEST] All resolutions tested!");
            StopTesting();
            return;
        }

        var res = Resolutions[_currentResolutionIndex];
        var fov = TestFovValues[_currentFovIndex];
        
        // Set resolution and FOV
        Screen.SetResolution(res.width, res.height, FullScreenMode.Windowed);
        Plugin.CameraFieldOfView.Value = fov;
        Patches.UpdateConfigCache();
        Patches.UpdateAllBorders();
        Plugin.Log.LogWarning("");
        Plugin.Log.LogWarning($"[TEST] Resolution: {res.width}x{res.height} ({res.aspect}) - Aspect: {res.ratio:F3}");
        Plugin.Log.LogWarning($"[TEST] FOV: {fov:F1}");
        Plugin.Log.LogWarning($"[TEST] >>> Are edges visible? Press Y or N <<<");
    }

    private static void RecordResult(bool edgesVisible)
    {
        var res = Resolutions[_currentResolutionIndex];
        var fov = TestFovValues[_currentFovIndex];
        
        TestResults.Add(new TestResult
        {
            Width = res.width,
            Height = res.height,
            AspectName = res.aspect,
            AspectRatio = res.ratio,
            FOV = fov,
            EdgesVisible = edgesVisible,
            Timestamp = DateTime.Now
        });
        
        Plugin.Log.LogWarning($"[RECORDED] Edges {(edgesVisible ? "VISIBLE" : "NOT visible")} at {res.width}x{res.height}, FOV {fov}");
    }

    private static void NextTest()
    {
        _currentFovIndex++;
        
        // If we've tested all FOVs for this resolution, move to next resolution
        if (_currentFovIndex >= TestFovValues.Length)
        {
            _currentFovIndex = 0;
            _currentResolutionIndex++;
            
            // Show progress
            if (_currentResolutionIndex < Resolutions.Length)
            {
                Plugin.Log.LogWarning($"[PROGRESS] Completed resolution {_currentResolutionIndex}/{Resolutions.Length}");
            }
        }
        
        SetupNextTest();
    }

    private static void ExportResults()
    {
        if (TestResults.Count == 0)
        {
            Plugin.Log.LogWarning("[EXPORT] No results to export");
            return;
        }

        // Export CSV
        var csv = new StringBuilder();
        csv.AppendLine("Width,Height,AspectName,AspectRatio,FOV,EdgesVisible");
        
        foreach (var result in TestResults.OrderBy(r => r.AspectRatio).ThenBy(r => r.FOV))
        {
            csv.AppendLine($"{result.Width},{result.Height},{result.AspectName},{result.AspectRatio:F4},{result.FOV:F1},{(result.EdgesVisible ? "YES" : "NO")}");
        }

        var filename = $"EdgeTest_Results_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
        var path = Path.Combine(Application.dataPath, "..", filename);
        File.WriteAllText(path, csv.ToString());
        
        Plugin.Log.LogWarning($"[EXPORT] Results saved to: {filename}");
        
        // Generate formula suggestion
        GenerateFormulaSuggestion();
    }

    private static void GenerateFormulaSuggestion()
    {
        // Find the minimum aspect ratio where edges appear for each FOV
        var thresholds = TestResults
            .Where(r => r.EdgesVisible)
            .GroupBy(r => r.FOV)
            .Select(g => new { FOV = g.Key, MinAspect = g.Min(r => r.AspectRatio) })
            .OrderBy(x => x.FOV)
            .ToList();

        if (thresholds.Count < 2)
        {
            Plugin.Log.LogWarning("[FORMULA] Not enough data points to suggest formula");
            return;
        }

        // Try to find a linear relationship
        var fovDiff = thresholds.Last().FOV - thresholds.First().FOV;
        var aspectDiff = thresholds.Last().MinAspect - thresholds.First().MinAspect;
        
        if (Math.Abs(fovDiff) > 0.01f)
        {
            var slope = aspectDiff / fovDiff;
            var baseAspect = thresholds.First().MinAspect - (slope * thresholds.First().FOV);
            
            Plugin.Log.LogWarning("========================================");
            Plugin.Log.LogWarning("[FORMULA] Suggested edge visibility formula:");
            Plugin.Log.LogWarning($"[FORMULA] Edge threshold aspect = {baseAspect:F4} + (FOV * {slope:F4})");
            Plugin.Log.LogWarning($"[FORMULA] Edges visible when: CurrentAspect > {baseAspect:F4} + (FOV * {slope:F4})");
            Plugin.Log.LogWarning("========================================");
        }
    }

    private static readonly (int width, int height, string aspect, float ratio)[] Resolutions =
    [
        // 5:4 (1.250)
        (1280, 1024, "5:4", 1.250f),

        // 4:3 (1.333)
        (1024, 768, "4:3", 1.333f),
        (1600, 1200, "4:3", 1.333f),
        (1920, 1440, "4:3", 1.333f), // Max height at 4:3

        // 16:10 (1.600)
        (1440, 900, "16:10", 1.600f),
        (1680, 1050, "16:10", 1.600f),
        (1920, 1200, "16:10", 1.600f),
        (2304, 1440, "16:10", 1.600f), // Max height at 16:10

        // 16:9 (1.778)
        (1280, 720, "16:9", 1.778f),
        (1920, 1080, "16:9", 1.778f),
        (2560, 1440, "16:9", 1.778f), // Max height at 16:9

        // 18:9 (2.000) - 2:1
        (2880, 1440, "18:9", 2.000f), // Max height at 18:9
        (2560, 1280, "18:9", 2.000f),
        (2000, 1000, "18:9", 2.000f),

        // 19:9 (2.111)
        (3040, 1440, "19:9", 2.111f), // Max height at 19:9
        (2533, 1200, "19:9", 2.111f),

        // 20:9 (2.222)
        (3200, 1440, "20:9", 2.222f), // Max height at 20:9
        (2560, 1152, "20:9", 2.222f),

        // 21:9 (2.370) - Common ultrawide
        (2560, 1080, "21:9", 2.370f),
        (3440, 1452, "21:9", 2.370f), // Exact 21:9 at max width

        // 21.5:9 (2.389) 
        (3440, 1440, "21.5:9", 2.389f), // Your actual monitor

        // 21.6:9 (2.400)
        (3440, 1433, "21.6:9", 2.400f), // Max width
        (2400, 1000, "21.6:9", 2.400f),

        // 22:9 (2.444)
        (3440, 1408, "22:9", 2.444f), // Max width
        (2200, 900, "22:9", 2.444f),

        // 24:9 (2.667)
        (3440, 1290, "24:9", 2.667f), // Max width
        (2400, 900, "24:9", 2.667f),

        // 32:9 (3.556) - Super ultrawide
        (3440, 968, "32:9", 3.556f), // Max width, calculated height
        (2560, 720, "32:9", 3.556f), // 720p super ultrawide
        (3200, 900, "32:9", 3.556f),

        // 36:9 (4.000) - 4:1
        (3440, 860, "36:9", 4.000f), // Max width
        (2400, 600, "36:9", 4.000f),

        // 48:9 (5.333) - Extreme test
        (3440, 645, "48:9", 5.333f), // Max width
        (2560, 480, "48:9", 5.333f),
        
        // 52:9 (5.778) - Extreme test
        (3440, 595, "52:9", 5.778f), // Max width
        (2600, 450, "52:9", 5.778f),
        
        // 64:9 (7.111) - Extreme test
        (3440, 484, "64:9", 7.111f), // Max width
        (2560, 360, "64:9", 7.111f),
        
        // 80:9 (8.889) - Extreme test
        (3440, 405, "80:9", 8.889f), // Max width
        (2880, 324, "80:9", 8.889f), // 324p super extreme
        
    ];
}