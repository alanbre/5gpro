﻿using _5gpro.StaticFiles;
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
            var path = AppDomain.CurrentDomain.BaseDirectory + "5gpro.ini";
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                }
            }
            IniData data = parser.ReadFile(AppDomain.CurrentDomain.BaseDirectory + "5gpro.ini");
            return data;
        }
        public static void LeDadosEstaticos()
        {
            var data = PegarArquivo();
            Configuracao.CodUsuario = data["Login"]["codusuario"];
            Configuracao.BancoIP = data["Base de dados"]["ip"];
            Configuracao.BancoUsuario = data["Base de dados"]["usuario"];
            Configuracao.BancoSenha = data["Base de dados"]["senha"];
        }

        public static void SalvaDadoEstatico(string grupo, string item, string valor)
        {
            IniData data = PegarArquivo();
            data[grupo][item] = valor;
            var parser = new FileIniDataParser();
            var path = AppDomain.CurrentDomain.BaseDirectory + "5gpro.ini";
            parser.WriteFile(path, data);
        }
    }
}
