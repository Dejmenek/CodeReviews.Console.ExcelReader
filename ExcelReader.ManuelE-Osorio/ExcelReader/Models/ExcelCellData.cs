namespace ExcelReader.Models;

public class ExcelCellData<T> where T : struct
{    
    public string? CellTitle {get; set;}
    public T? CellValue {get; set;}

    public override string ToString()
    {
        return $"{CellTitle}: {CellValue}";
    }
}