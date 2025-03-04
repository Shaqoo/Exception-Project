// try
// {
// using(FileStream fileStream = File.Create("Shaqo"))
// {
//     Console.WriteLine("It has been created successfully");
// }
// }
// catch(Exception MyExcep)
// {
//     Console.WriteLine(MyExcep.ToString());
// }
// if (File.Exists("Shaqo.txt"))
// {
//     File.Delete("Shaqo.txt");
//     using(FileStream file = File.Create("Books"))
//     {
//         Console.WriteLine("It has been created successfully");
//     }
//     using(StreamWriter streamWriter = File.CreateText("Books.txt"))
//     {
//         streamWriter.WriteLine("I am a boy");
//         streamWriter.WriteLine("I go to school on a regular basis");
//         streamWriter.WriteLine("I am a muslim");
//     }
//     string[] myArray = File.ReadAllLines("Books.txt");
//     foreach (string item in myArray)
//     {
//      Console.WriteLine(item);   
//     }
// }
static void Exception()
{
    Exception e = new Exception("Wrong input");
    throw e;
}
Exception();

int m = 8;