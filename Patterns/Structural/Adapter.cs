namespace Patterns.Structural;
public record PersonData(string Name, int Age);

public record Person(string Name, int Age)
{
  public string Name { get; } = Name;
  public int Age { get; } = Age;
}

public class AdapterClient
{
  private readonly IPrinter _printer;

  public AdapterClient(IPrinter printer)
  {
    _printer = printer;
  }

  public void PrintPersonData(PersonData personData)
  {
    _printer.Print(personData);
  }
}

public interface IPrinter
{
  void Print(PersonData personData);
}

public interface IPersonPrinter
{
  void SpecialPrint(Person person);
}

public class PersonPrinter : IPersonPrinter
{
  public void SpecialPrint(Person person)
  {
    Console.WriteLine($"Person Printer: Name: {person.Name}, Age: {person.Age}");
  }
}

public class PersonDataToPersonAdapter : IPrinter
{
  private readonly IPersonPrinter _personPrinter;

  public PersonDataToPersonAdapter(IPersonPrinter personPrinter)
  {
    _personPrinter = personPrinter;
  }

  public void Print(PersonData personData)
  {
    var person = new Person(personData.Name, personData.Age);
    _personPrinter.SpecialPrint(person);
  }
}
