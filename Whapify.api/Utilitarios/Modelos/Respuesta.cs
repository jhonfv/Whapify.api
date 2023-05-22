namespace Whapify.api.Utilitarios.Modelos
{
    public class Respuesta<T>
    {
        public int code { get; private set; }
        public T data { get; private set; }
        public bool error { get; private set; }

        public Respuesta(T data, int code =200,  bool error = false)
        {
            this.code = code;
            this.data = data;
            this.error = error;
        }

        public Respuesta<T> get() {
            return this;
        }
    }
}
