using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    [Test]
    public void Create_Hero_Success()
    {
        Hero hero = new Hero("Ivo", 1);
        Assert.AreEqual(hero.Name, "Ivo");
    }

    [Test]
    public void Add_Hero_In_Repository_Success()
    {
        HeroRepository repository = new HeroRepository();
        string result = repository.Create(new Hero("Gosho", 3));

        Assert.AreEqual("Successfully added hero Gosho with level 3", result);
    }

    [Test]
    public void Try_Hero_With_Null_Value_In_Repository()
    {
        HeroRepository repository = new HeroRepository();

        Assert.Throws<ArgumentNullException>(() => repository.Create(null));
    }

    [Test]
    public void Try_Add_Exist_Hero_In_Repository()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Pesho", 2));

        Assert.Throws<InvalidOperationException>(() => repository.Create(new Hero("Pesho", 2)));
    }

    [Test]
    public void Try_Remove_With_Null_Value()
    {
        HeroRepository repository = new HeroRepository();
        Assert.Throws<ArgumentNullException>(() => repository.Remove(null));
    }

    [Test]
    public void Remove_Hero_From_Repository_Success()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Gosho", 1));
        bool result = repository.Remove("Gosho");
        Assert.AreEqual(true, result);
    }

    [Test]
    public void Remove_Hero_From_Repository_Unsuccessfully()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Gosho", 1));

        bool result = repository.Remove("Pesho");
        Assert.AreEqual(false, result);
    }

    [Test]
    public void Get_Hero_With_Highest_Level()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Gosho", 1));
        repository.Create(new Hero("Ivo", 3));
        repository.Create(new Hero("Kiro", 10));

        var result = repository.GetHeroWithHighestLevel();
        Assert.AreEqual(result.Name, "Kiro");
    }

    [Test]
    public void Get_Hero_Success()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Gosho", 1));

        var result = repository.GetHero("Gosho");
        Assert.AreEqual(result.Name, "Gosho");
    }

    [Test]
    public void Get_Hero_Unsuccessfully()
    {
        HeroRepository repository = new HeroRepository();
        repository.Create(new Hero("Gosho", 1));

        var result = repository.GetHero("Kiro");
        Assert.AreEqual(result, null);
    }
}