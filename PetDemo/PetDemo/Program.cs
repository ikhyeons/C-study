using System;

/// <summary>
/// 애완동물
/// </summary>
class Pet
{
    /// <summary>
    /// 몸무게
    /// </summary>
    public int Weight { get; set; }
    /// <summary>
    /// 먹이를 주면 몸무게 증가
    /// </summary>
    /// <param name="weight">몸무게</param>
    public void Feed(int weight)
    {
        Weight += weight;
    }
}

class PetDemo
{
    static void Main(string[] args)
    {
        Pet pet = new Pet();
        pet.Weight = 50;
        pet.Feed(10);
        Console.WriteLine(pet.Weight);
    }
}