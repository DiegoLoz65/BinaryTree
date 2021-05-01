class Nodo{
    private int dato;
    private Nodo izquierda;
    private Nodo derecha;
    public int Dato {
        get => dato;
        set => dato = value;
    }

    internal Nodo Izquierda   {
        get => izquierda;
        set => izquierda = value;
    } 

    internal Nodo Derecha{
        get => derecha;
        set => derecha = value;
    }

    public Nodo(){
        dato = 0;
        izquierda = null;
        derecha = null;
    }
}