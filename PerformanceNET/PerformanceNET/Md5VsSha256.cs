using BenchmarkDotNet.Attributes;
using System;
using System.Security.Cryptography;

namespace PerformanceNET
{
    public class Md5VsSha256
    {
        private SHA256 sha256 = SHA256.Create();

        private MD5 md5 = MD5.Create();

        private byte[] data;

        [Params(1000, 10000)]
        public int N;

        //Inicializando um array de bytes para iniciar os testes de performance entre um de tamanho 1000 e outro de 10000 pelo Benchmark.NET
        [GlobalSetup]
        public void Setup()
        {            
            data = new byte[N];
            new Random().NextBytes(data); //Gerando os números de bytes aleatórios
        }

        [Benchmark]
        public byte[] Sha256()
        {
            return sha256.ComputeHash(data);
        }

        [Benchmark]
        public byte[] Md5()
        {
            return md5.ComputeHash(data);
        }
    }
}
