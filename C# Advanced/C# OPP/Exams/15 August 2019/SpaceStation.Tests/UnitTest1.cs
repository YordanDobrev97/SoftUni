using System;
using System.Linq;
using System.Reflection;

using NUnit.Framework;
using SpaceStation;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

[TestFixture]
public class Tests_000_005
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateAstronautsExists()
    {
        var typesToAssert = new[]
        {
            "AstronautRepository",
            "PlanetRepository"
        };

        foreach (var typeName in typesToAssert)
        {
            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
        }
    }

    private static Type GetType(string name)
    {
        //AstronautRepository
        //AstronautRepository
        var types = ProjectAssembly
            .GetTypes();

        var value = types.GetValue(12);
        var type = types
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}