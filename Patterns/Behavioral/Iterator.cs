namespace Patterns.Behavioral;

public interface IIntIterator
{
  bool HasNext();
  int Next();
}

public class IntArrayIterator : IIntIterator
{
  private readonly int[] _array;
  private int _currentIndex;

  public IntArrayIterator(int[] array)
  {
    _array = array;
    _currentIndex = 0;
  }

  public bool HasNext()
  {
    return _currentIndex < _array.Length;
  }

  public int Next()
  {
    if (!HasNext())
      throw new InvalidOperationException("No more elements in the array.");

    return _array[_currentIndex++];
  }
}

public interface IIntCollection
{
  IIntIterator CreateIterator();
}

public class IntArrayCollection : IIntCollection
{
  private readonly int[] _array;

  public IntArrayCollection(int[] array)
  {
    _array = array;
  }

  public IIntIterator CreateIterator()
  {
    return new IntArrayIterator(_array);
  }
}