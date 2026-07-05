namespace Catering;

/// <summary>
/// Base kitchen aggregate.
/// </summary>
public abstract class Kitchen : IEquatable<Kitchen>
{
    
    /// <summary>
    /// Identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Kitchen is open.
    /// </summary>
    public bool IsOpened { get; private set; }
    
    /// <summary>
    /// Kitchen width.
    /// </summary>
    public int Width { get; set; }
    
    /// <summary>
    /// Kitchen length.
    /// </summary>
    public int Length { get; set; }
    
    /// <summary>
    /// Kitchen height.
    /// </summary>
    public int Height { get; set; }
    
    /// <summary>
    /// Open time.
    /// </summary>
    public virtual TimeOnly OpenTime { get; set; }
    
    /// <summary>
    /// Close time.
    /// </summary>
    public virtual TimeOnly CloseTime { get; set; }
    
    /// <summary>
    /// Kitchen area.
    /// </summary>
    public int Area => Width * Length;

    /// <summary>
    /// Kitchen volume.
    /// </summary>
    public int Volume => Width * Length * Height;

    /// <summary>
    /// Opens the kitchen.
    /// </summary>
    public virtual void Open()
    {
        if (TimeOnly.FromDateTime(DateTime.Now) < OpenTime)
        {
            throw new Exception("Now is non-working hours");
        }

        IsOpened = true;
    }

    /// <summary>
    /// Closes the kitchen.
    /// </summary>
    public virtual void Close()
    {
        if (TimeOnly.FromDateTime(DateTime.Now) < CloseTime)
        {
            throw new Exception("Now is working hours.");
        }

        IsOpened = false;
    }

    /// <summary>
    /// Equals two kitchens.
    /// </summary>
    /// <param name="other">Other kitchen.</param>
    /// <returns></returns>
    public bool Equals(Kitchen? other)
    {
        if (other is null)
        {
            return false;
        }

        return Id == other.Id;
    }

    /// <summary>
    /// Convert kitchen to string.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => Id.ToString();

}