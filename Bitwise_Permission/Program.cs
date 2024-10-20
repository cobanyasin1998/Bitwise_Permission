
//Bitwise AND (&) Operatörü
//İki sayının karşılık gelen bitlerini karşılaştırır. İki sayının karşılık gelen bitleri 1 ise sonuç 1 olur, diğer durumlarda sonuç 0 olur.
int a = 12; // 1100
int b = 5; // 0101
int andResult = a & b; // 0100
Console.WriteLine($"AND Operation:\t{a} & {b} = {andResult}");

//Bitwise OR (|) Operatörü
//İki sayının karşılık gelen bitlerini karşılaştırır. İki sayının karşılık gelen bitlerinden en az biri 1 ise sonuç 1 olur, diğer durumlarda sonuç 0 olur.
int orResult = a | b; // 1101
Console.WriteLine($"OR Operation:\t{a} | {b} = {orResult}");

//Bitwise XOR (^) Operatörü
//İki sayının karşılık gelen bitlerini karşılaştırır. İki sayının karşılık gelen bitleri farklı ise sonuç 1 olur, aynı ise sonuç 0 olur.
int xorResult = a ^ b; // 1001
Console.WriteLine($"XOR Operation:\t{a} ^ {b} = {xorResult}");

//Bitwise NOT (~) Operatörü
//Bir sayının bitlerini tersine çevirir. 1 olan bit 0, 0 olan bit 1 olur.
int notResult = ~a; // 0011
Console.WriteLine($"NOT Operation:\t~{a} = {notResult}");

Console.ReadLine();

var permission = FilePermissions.Read |   //0001
                 FilePermissions.Write |  //0010
                 FilePermissions.Execute;  //0100

permission = permission & ~FilePermissions.Read; // 0111 & 1110 = 0110

//              0110                  0001                  0000
var hasRead = (permission & FilePermissions.Read) == FilePermissions.Read;
//              0110                  0010                 0010
var hasWrite = (permission & FilePermissions.Write) == FilePermissions.Write;
//              0110                  0100                 0100
var hasExecute = (permission & FilePermissions.Execute) == FilePermissions.Execute;
//              0110                  1000                 0000
var hasAdmin = (permission & FilePermissions.Admin) == FilePermissions.Admin;

hasRead = permission.HasFlag(FilePermissions.Read); //-> kullanımı daha kolaydır.

enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 2,
    //ReadAndWrite = Read | Write,
    Execute = 4,
    Admin = 8
}