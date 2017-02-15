using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Tt.EmitHelper
{
    public class EmitHelper
    {
        public ILGenerator _il;
        public EmitHelper(ILGenerator il)
        {
            _il = il;
        }

        /// <summary>
        /// WriteLine
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void EmitCallWriteLine<T>()
        {
            MethodInfo m = typeof(Console).GetMethod(SysMethodSet.WriteLine,new Type[] { typeof(T)});
            _il.Emit(OpCodes.Call, m);
        }

        /// <summary>
        /// ToString
        /// </summary>
        public void EmitCallToString()
        {
            MethodInfo m = typeof(Object).GetMethod(SysMethodSet.ToString, new Type[0]);
            _il.Emit(OpCodes.Callvirt, m);
        }

        public void EmitRet()
        {
            _il.Emit(OpCodes.Ret);
        }

    }
   
}
