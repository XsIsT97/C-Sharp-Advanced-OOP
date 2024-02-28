using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ValidationAttributes
{
    public class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property
                    .GetCustomAttributes<MyValidationAttribute>()
                    .ToArray();

                foreach (var attribute in attributes)
                {
                    bool IsValid = attribute.IsValid(property.GetValue(obj));

                    if (IsValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
