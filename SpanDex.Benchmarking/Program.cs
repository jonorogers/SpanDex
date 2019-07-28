using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace SpanDex.Benchmarking {
    [RankColumn]
    [MemoryDiagnoser]
    public class SpanReaderVsBitConverter {
        private byte[] data;

        [Params(1000, 10000)]
        public int N;

        [GlobalSetup]
        public void Setup() {
            data = new byte[N * sizeof(Int16)];
        }

        [Benchmark]
        public void SpanReader() {
            SpanReader reader = data;

            for (int i = 0; i < N; i += 2) {
                var v = reader.ReadInt16LittleEndian();
            }
        }

        [Benchmark]
        public void BitConvert() {
            for (int i = 0; i < N; i += 2) {
                var v = BitConverter.ToInt16(data, i);
            }
        }

        [Benchmark]
        public void Manual() {
            for (int i = 0; i < N; i += 2) {
                var v = (short)((data[i] << 8) | data[i + 1]);
            }
        }
    }

    public class Program {
        public static void Main() {
            var summary = BenchmarkRunner.Run<SpanReaderVsBitConverter>();
        }
    }
}