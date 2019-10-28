using System;

namespace shared
{
    public class Result<T>
    {
        private Result(object data, string mensagem, bool valido)
        {
            Data = data;
            Mensagem = mensagem;
            Valido = valido;
        }

        private Result(object data)
        {
            Data = data;
        }

        private Result(bool valido)
        {
            Valido = valido;
        }

        public object Data { get; private set; }
        public string Mensagem { get; private set; }
        public bool Valido { get; private set; }

        public static Result<T> Falha(T data, string mensagem) => new Result<T>(data, mensagem, false);

        public static Result<T> Sucesso(object data, string mensagem) => new Result<T>(data, mensagem, true);

        public static Result<T> Sucesso(object data) => new Result<T>(data);

        public static Result<T> Sucesso() => new Result<T>(true);
    }
}
