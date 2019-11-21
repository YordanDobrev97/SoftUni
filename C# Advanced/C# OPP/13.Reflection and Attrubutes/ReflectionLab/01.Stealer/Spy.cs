using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fields)
    {
        var type = Type.GetType(className);
        var instance = Activator.CreateInstance(type);

        var allFields = type.GetFields(BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.NonPublic |
            BindingFlags.Public);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Class under investigation: {className}");

        foreach (var item in allFields)
        {
            var value = item.GetValue(instance);
            var field = item.Name;
            if (fields.Contains(field))
            {
                stringBuilder.AppendLine($"{field} = {value}");
            }
        }

        return stringBuilder.ToString().TrimEnd();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder stringBuilder = new StringBuilder();

        Type type = Type.GetType(className);
        FieldInfo[] fields = type.
            GetFields(
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public);

        MethodInfo[] publicMethods = type.GetMethods(
            BindingFlags.Public | 
            BindingFlags.Instance);

        MethodInfo[] privateMethods = type.GetMethods(
            BindingFlags.Instance |
            BindingFlags.NonPublic
            );

        foreach (var field in fields)
        {
            stringBuilder.AppendLine($"{field.Name} musb be private!");
        }

        foreach (var method in privateMethods.Where(x => x.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in publicMethods.Where(x => x.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private!");
        }

        return stringBuilder.ToString().TrimEnd();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"All Private Methods of Class: {className}");

        Type type = Type.GetType(className);

        var baseClass = type.BaseType;
        stringBuilder.AppendLine($"Base Class: {baseClass.Name}");

        var methods = type.GetMethods(
            BindingFlags.Instance |
            BindingFlags.NonPublic);

        foreach (var method in methods)
        {
            stringBuilder.AppendLine($"{method.Name}");
        }

        return stringBuilder.ToString();
    }

    public string CollectGettersAndSetters(string className)
    {
        StringBuilder stringBuilder = new StringBuilder();

        Type type = Type.GetType(className);
        var methods = type.GetMethods(
            BindingFlags.Instance |
            BindingFlags.NonPublic |
            BindingFlags.Public |
            BindingFlags.Static);

        var getters = methods.Where(x => x.Name.StartsWith("get"));
        var setters = methods.Where(x => x.Name.StartsWith("set"));

        foreach (var getter in getters)
        {
            stringBuilder.AppendLine($"{getter.Name} will return {getter.ReturnType}");
        }

        foreach (var setter in setters)
        {
            Type typeSetter = setter.GetParameters().First().ParameterType;
            stringBuilder.AppendLine($"{setter.Name} will set field of {typeSetter}");
        }

        return stringBuilder.ToString();
    }
}
