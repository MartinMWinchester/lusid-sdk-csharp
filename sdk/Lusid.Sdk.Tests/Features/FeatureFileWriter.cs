﻿using System.IO;

namespace Lusid.Sdk.Tests.Features
{
    public class FeatureFileWriter
    {
        private readonly string _fullFilepath;

        public FeatureFileWriter(string partialFilepath)
        {
            _fullFilepath = SetFilepath(partialFilepath);
        }
        public void CreateAndWriteFile(string data)
        {
            File.WriteAllText(_fullFilepath, data);
        }

        public string ReadFile()
        {
            return File.ReadAllText(_fullFilepath);
        }

        public void CheckAndRemoveExistingFile()
        {
            if (File.Exists(_fullFilepath))
            {
                File.Delete(_fullFilepath);
            }
        }

        private string SetFilepath(string filepath)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var baseProjectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.ToString();
            var fullFilepath = Path.Join(baseProjectDirectory, filepath);
            return fullFilepath;
        }
    }
}