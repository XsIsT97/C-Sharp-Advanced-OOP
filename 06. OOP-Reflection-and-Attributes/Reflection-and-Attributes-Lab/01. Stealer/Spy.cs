using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] requestedFields)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public |
                                                                    BindingFlags.NonPublic |
                                                                    BindingFlags.Static |
                                                                    BindingFlags.Instance);

            Object clssInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {classType.FullName}");

            foreach (var field in classFields.Where(field => requestedFields.Contains(field.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(clssInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
