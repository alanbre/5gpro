using _5gpro.StaticFiles;
using IniParser;
using IniParser.Model;
using System;
using System.IO;

namespace _5gpro.Funcoes
{
    public static class DadosEstaticos
    {
        private static IniData PegarArquivo()
        {
            var parser = new FileIniDataParser();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "5gpro\\");
            var path = folder + "5gpro.ini";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();                
            }
            IniData data = parser.ReadFile(path);
            return data;
        }
        public static void LeDadosEstaticos()
        {
            var data = PegarArquivo();
            Configuracao.CodUsuario = data["Login"]["codusuario"];
            Configuracao.BancoIP = data["Base de dados"]["ip"];
            Configuracao.BancoUsuario = data["Base de dados"]["usuario"];
            Configuracao.BancoSenha = data["Base de dados"]["senha"];
            Configuracao.BancoPorta = data["Base de dados"]["porta"];
        }
        public static void SalvaDadoEstatico(string grupo, string item, string valor)
        {
            IniData data = PegarArquivo();
            data[grupo][item] = valor;
            var parser = new FileIniDataParser();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "5gpro\\");
            var path = folder + "5gpro.ini";
            parser.WriteFile(path, data);
        }
    }
}
