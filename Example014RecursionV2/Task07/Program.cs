// Как вытащить информацию из директории

string path = "/Users/macbookpro/Desktop/Тестировщик/Обучение/Examples/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

// Получим информацию о созданных файлах в папке

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}