using System;

class ArbolBinarioBusqueda{
    private Nodo raiz;
    private Nodo referencia;
    private int i = 0;

    internal Nodo Raiz{
        get => raiz;
        set => raiz = value;
    }

    public ArbolBinarioBusqueda(){
        raiz = null;
    }

    public Nodo Insertar(int pDato, Nodo pNodo){
        Nodo tmp = null;
        //Caso Base
        if(pNodo == null){
            tmp = new Nodo();
            tmp.Dato = pDato;
            return tmp;
        }
        //Parte Inductiva
        if(pDato < pNodo.Dato){
            pNodo.Izquierda =Insertar(pDato, pNodo.Izquierda);
        }

        //Parte Inductiva 2
        if(pDato > pNodo.Dato){
            pNodo.Derecha = Insertar(pDato, pNodo.Derecha);
        }

        return pNodo;
    }

    public void ApuntadorPreOrder(Nodo pNodo){
        //Caso Base
        if(pNodo == null){
            return;
        }

        for(int n = 0; n < i; n++){
            Console.Write(" ");
        }
        //R I D -> Parte Indcutiva
        Console.WriteLine(pNodo.Dato);
        if (pNodo.Izquierda != null){
            i++;
            Console.Write("I ");
            ApuntadorPreOrder(pNodo.Izquierda);
            i--;
        }
         if (pNodo.Derecha != null){
             i++;
             Console.Write("D");
             ApuntadorPreOrder(pNodo.Derecha);
             i--;
         }
    }

    public int EncontrarMinimo(Nodo pNodo){
        if (pNodo == null){
            return 0;
        }
        referencia = pNodo;
        int minimo = referencia.Dato;
        while(referencia.Izquierda != null){
            referencia = referencia.Izquierda;
            minimo = referencia.Dato;
        }
        return minimo;
    }

    public int EncontrarMaximo(Nodo pNodo){
        if(pNodo == null){
            return 0;
        }

        referencia = pNodo;
        int maximo = referencia.Dato;
        while(referencia.Derecha != null){
            referencia = referencia.Derecha;
            maximo = referencia.Dato;
        }
        return maximo;
    }

   public Nodo Borrar(Nodo pNodo, int pDato){
       if (pNodo == null){
           return pNodo;
       }
        else if(pDato < pNodo.Dato){
            pNodo.Izquierda = Borrar(pNodo.Izquierda, pDato);

        }
        else if(pDato > pNodo.Dato){
            pNodo.Derecha = Borrar(pNodo.Derecha, pDato);
        }

        
   }

   


}