using System;
using System.Linq;
using PugMod;
using UnityEngine;

namespace Mods.UltraWide
{
    public static class Extensions
    {
        public static string GetFullPath(this Transform current)
        {
            var path = current.name;
            while (current.parent != null)
            {
                current = current.parent;
                path = current.name + "/" + path;
            }

            return path;
        }


        public static T GetValue<T>(this object obj, string fieldName)
        {
            var field = obj.GetType()
                .GetMembersChecked()
                .FirstOrDefault(info => info.GetNameChecked().Equals(fieldName));
            if (field == null)
                throw new MissingFieldException(obj.GetType().GetNameChecked(), fieldName);

            return (T) API.Reflection.GetValue(field, obj);
        }

        public static void SetValue<T>(this object obj, string fieldName, T value)
        {
            var field = obj.GetType()
                .GetMembersChecked()
                .FirstOrDefault(info => info.GetNameChecked().Equals(fieldName));
            if (field == null)
                throw new MissingFieldException(obj.GetType().GetNameChecked(), fieldName);

            API.Reflection.SetValue(field, obj, value);
        }

        public static T Invoke<T>(this object obj, string fieldName, params object[] args)
        {
            var field = obj.GetType()
                .GetMembersChecked()
                .FirstOrDefault(info => info.GetNameChecked().Equals(fieldName));
            if (field == null)
                throw new MissingFieldException(obj.GetType().GetNameChecked(), fieldName);

            return (T) API.Reflection.Invoke(field, obj, args);
        }
    }
}