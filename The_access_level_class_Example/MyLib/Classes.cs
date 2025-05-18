using System;


namespace MyLib
{
    public class Vehicle
    {
         public string Owner_public { get; set; }
        //如果这里用了internal修饰符的话，只能在MyLib这个项目中的其他类访问Owner这个属性,被限制在了MyLib这个程序集里面
         internal int Owner_internal { get; set; }

         protected int Owner_protected { get; set; }

         private int Owner_private { get; set; }


         protected int _rpm;
         private int _fuel;

         public void Refuel()
         {
             _fuel = 100;
         }
         protected void Burn(int fuel)//这里的话如果你既不想把这个方法暴露给外部的程序集The_access_level_class_Example,
             //又需要这个方法能被他的子类Car访问的话.这里就要用protected
         {
             _fuel-=fuel;
         }

         public void Accelerate()
         {
             Burn(1);
             _rpm += 1000;
         }

         public int Speed { get { return _rpm / 100; } }
    }

    public class Car : Vehicle
    {
        
        public void ShowOwner()
        {
            Console.WriteLine(Owner_internal);
            Console.WriteLine(Owner_public);
            //Console.WriteLine(Owner_private);//访问级别受限
        }

        public void TurboAccelerate()
        {
           
            Burn(2);
            _rpm += 3000;
        }
    }
}
