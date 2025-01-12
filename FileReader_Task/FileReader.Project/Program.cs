﻿using FileReader.BusinessLogic;
using FileReader_BusinessLogic.Interfaces;

IFileManager fileManager = new FileManager();


Console.WriteLine("Insert folder path");
string path = Console.ReadLine();

// palikti viena metod BL
var localFolder = fileManager.RetrieveLocalFolder(path);
fileManager.RefreshDb(localFolder);


var folder = fileManager.RetrieveDbFolder(path);

if (folder is not null)
{
    foreach (var item in folder.Files)
    {
        Console.WriteLine(item.Name);
    }
}
else
{
    Console.WriteLine("Folder not found");

}


