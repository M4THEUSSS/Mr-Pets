namespace Mr-Pets
 {
     class Cliente
    {
 publicstring nome{get; set;}
 public string endereco {get; set;}
 public floatvalor{get; protected set;}
 public floatvalor_imposto {get; protectedset;}
 public floattotal{get; protectedset;}
 public virtual void Pagar_Imposto(float v)
 {
 this.valor = v;
 this.valor_imposto = this.valor * 10 / 100;
 this.total = this.valor + this.valor_imposto;
 }
 }
 }
 