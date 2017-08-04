using System;
using System.Reflection;
using System.Linq;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string className)
    {
        Type myClass = Type.GetType(className);
        MethodInfo[] methods = myClass.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        foreach (var getMethod in methods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{getMethod.Name} will return {getMethod.ReturnType.FullName}");
        }

        foreach (var setMethod in methods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{setMethod.Name} will set field of {setMethod.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type myType = Type.GetType(className);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {myType.BaseType.Name}");
        MethodInfo[] methods = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

    public string StealFieldInfo(string insvestigatedClass, params string[] investigatedFields)
    {
        StringBuilder sb = new StringBuilder();
        Type myType = Type.GetType(insvestigatedClass);
        FieldInfo[] fields = myType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        sb.AppendLine($"Class under investigation: {insvestigatedClass}");
        Object investigatedClassInstance = Activator.CreateInstance(myType, new object[] { });

        foreach (FieldInfo field in fields)
        {
            if (investigatedFields.Contains(field.Name))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(investigatedClassInstance)}");
            }
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type myType = Type.GetType(className);
        FieldInfo[] fields = myType.GetFields(BindingFlags.Instance | BindingFlags.Static  | BindingFlags.Public);
        MethodInfo[] publicMethods = myType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] nonPublicMethods = myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        foreach (FieldInfo fld in fields)
        {
            sb.AppendLine($"{fld.Name} must be private!");
        }

        foreach (MethodInfo meth in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{meth.Name} have to be public!");
        }

        foreach (MethodInfo meth in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{meth.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}