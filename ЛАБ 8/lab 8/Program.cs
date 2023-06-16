using System;
using System.IO;

class Program
{
    static void Main()
    {
        string baseDirectory = @"D:\OOP_lab08"; // Шлях до базового каталогу
        Directory.CreateDirectory(baseDirectory); // Створення каталогу OOP_lab08 на диску D:
        // Створення підкаталогів
        string groupNumber = "KN1-B21"; 
        string lastName = "Перепелюк";

        string groupDirectory = Path.Combine(baseDirectory, groupNumber);
        string lastNameDirectory = Path.Combine(baseDirectory, lastName);
        string sourcesDirectory = Path.Combine(baseDirectory, "Sources");
        string reportsDirectory = Path.Combine(baseDirectory, "Reports");
        string textsDirectory = Path.Combine(baseDirectory, "Texts");

        Directory.CreateDirectory(groupDirectory);
        Directory.CreateDirectory(lastNameDirectory);
        Directory.CreateDirectory(sourcesDirectory);
        Directory.CreateDirectory(reportsDirectory);
        Directory.CreateDirectory(textsDirectory);

        // Копіювання каталогів Texts, Sources та Reports до відповідного каталогу
        string destinationDirectory = Path.Combine(lastNameDirectory, "Texts");
        DirectoryCopy(textsDirectory, destinationDirectory);

        destinationDirectory = Path.Combine(lastNameDirectory, "Sources");
        DirectoryCopy(sourcesDirectory, destinationDirectory);

        destinationDirectory = Path.Combine(lastNameDirectory, "Reports");
        DirectoryCopy(reportsDirectory, destinationDirectory);

        // Переміщення каталогу Перепелюк до каталогу KN1-B21
        string newLocation = Path.Combine(groupDirectory, lastName);
        Directory.Move(lastNameDirectory, newLocation);

        // Створення файлу dirinfo.txt у каталозі Texts
        string fileInfo = GetDirectoryInfo(textsDirectory);
        string filePath = Path.Combine(textsDirectory, "dirinfo.txt");
        File.WriteAllText(filePath, fileInfo);

        Console.WriteLine("Операції з файловою системою виконані успішно.");S
    }

    // Функція для копіювання вмісту каталогу, включаючи підкаталоги та файли
    static void DirectoryCopy(string sourceDir, string destDir)
    {
        Directory.CreateDirectory(destDir);

        foreach (string file in Directory.GetFiles(sourceDir))
        {
            string destFile = Path.Combine(destDir, Path.GetFileName(file));
            File.Copy(file, destFile, true);
        }

        foreach (string subDir in Directory.GetDirectories(sourceDir))
        {
            string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
            DirectoryCopy(subDir, destSubDir);
        }
    }

    // Функція для отримання інформації про каталог
    static string GetDirectoryInfo(string directory)
    {
        string[] files = Directory.GetFiles(directory);
        string[] subDirectories = Directory.GetDirectories(directory);

        string info = $"Інформація про каталог: {directory}\n";
        info += $"Кількість файлів: {files.Length}\n";
        info += $"Кількість підкаталогів: {subDirectories.Length}\n\n";
        info += "Список файлів:\n";

        foreach (string file in files)
        {
            info += $"{Path.GetFileName(file)}\n";
        }

        return info;
    }
}
