#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QB4", "QB4Run () : (Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int)", new string[] { }, "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs", 196L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.QB4", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs", 5620L, 134L, 5L)]
#line hidden
namespace Quantum.QB4
{
    public class QB4Run : Operation<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public QB4Run(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QB4Run";
        String ICallable.FullName => "Quantum.QB4.QB4Run";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in) =>
        {
            // Counters for each combination.
#line 11 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0000 = 0L;
#line 12 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0001 = 0L;
#line 13 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0010 = 0L;
#line 14 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0011 = 0L;
#line 15 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0100 = 0L;
#line 16 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0101 = 0L;
#line 17 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0110 = 0L;
#line 18 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num0111 = 0L;
#line 19 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1000 = 0L;
#line 20 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1001 = 0L;
#line 21 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1010 = 0L;
#line 22 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1011 = 0L;
#line 23 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1100 = 0L;
#line 24 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1101 = 0L;
#line 25 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1110 = 0L;
#line 26 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var num1111 = 0L;
#line 28 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var qubits = Allocate.Apply(4L);
#line 30 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            foreach (var test in new Range(1L, 10000L))
            {
#line 32 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.Zero, qubits[0L]));
#line 33 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.Zero, qubits[1L]));
#line 34 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.Zero, qubits[2L]));
#line 35 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.Zero, qubits[3L]));
                //Demo of pass through (NOP)
                //Set (Zero, qubits[0]);
                //Set (One, qubits[1]);
                //Set (One, qubits[2]);
                //Set (Zero, qubits[3]);
                //Demo of NOT gate
                //Set (Zero, qubits[0]);
                //X(qubits[0]);
                //Demo of Hadamard -> superposes a qubit to [1/root(2) 1/root(2)]^T (50% of chance each).
                //Set (Zero, qubits[0]);
                //H(qubits[0]);
                //Demo of SWAP -> Exchanges the states of 2 qubits.
                //Set (One, qubits[0]);
                //SWAP (qubits[0],qubits[1]);
                //Demo of Controlled-NOT (CNOT) -> performs not operation on qubit 1 if qubit 0 is 1.
                //Set (One, qubits[0]);
                //Set (Zero, qubits[1]);
                //CNOT(qubits[0],qubits[1]);
                //Demo of Bell State -> 1/root(2) (|0000> + |0001>) = P(0000) = 50% e P(0001) = 50%.
                //Set (Zero, qubits[0]);
                //Set (Zero, qubits[1]);
                //H(qubits[0]);
                //CNOT(qubits[0],qubits[1]);
                //Demo of Toffoli Gate (aka CCNOT Gate) in general configuration. If qubits 0 and 1 are 1, inverts qubit 2.
                //Set (One, qubits[0]);
                //Set (One, qubits[1]);
                //Set (One, qubits[2]);
                //CCNOT(qubits[0],qubits[1],qubits[2]);
                //Demo of Toffoli Gate in NOT configuration -> Toffoli gate simulation a NOT gate.
                //Set (One, qubits[0]); // Always 1
                //Set (One, qubits[1]); // Always 1
                //Set (One, qubits[2]); // Input of NOT gate. Gets inverted by NOT
                //CCNOT(qubits[0],qubits[1],qubits[2]);
                //Demo of Toffoli Gate in AND configuration -> Toffoli gate simulation an AND gate.
                //Set (One, qubits[0]); // Input 1 of AND
                //Set (One, qubits[1]); // Input 2 of AND
                //Set (Zero, qubits[2]);// Initialized to 0. Gets the result of AND
                //CCNOT(qubits[0],qubits[1],qubits[2]);
                //Demo of Toffoli Gate in FANOUT configuration -> FANOUT = copies states 0 or 1 form one qubit to another. Produces different behaviur if quibit is superposed.
#line 85 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.One, qubits[0L]));
                // Always 1
#line 86 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.One, qubits[1L]));
                // Input & Pass through.
#line 87 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                Set.Apply((Result.Zero, qubits[2L]));
                //Initialized to 0. Gets a result of the fanout from qubits[1]
#line 88 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
                // Measuring qubits.
#line 93 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                var res0 = M.Apply(qubits[0L]);
#line 94 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                var res1 = M.Apply(qubits[1L]);
#line 95 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                var res2 = M.Apply(qubits[2L]);
#line 96 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                var res3 = M.Apply(qubits[3L]);
                // Updating counters:
#line 99 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                {
#line 99 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0000 = (num0000 + 1L);
                }

#line 100 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                {
#line 100 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0001 = (num0001 + 1L);
                }

#line 101 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                {
#line 101 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0010 = (num0010 + 1L);
                }

#line 102 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                {
#line 102 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0011 = (num0011 + 1L);
                }

#line 103 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                {
#line 103 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0100 = (num0100 + 1L);
                }

#line 104 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                {
#line 104 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0101 = (num0101 + 1L);
                }

#line 105 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                {
#line 105 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0110 = (num0110 + 1L);
                }

#line 106 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                {
#line 106 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num0111 = (num0111 + 1L);
                }

#line 107 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                {
#line 107 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1000 = (num1000 + 1L);
                }

#line 108 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                {
#line 108 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1001 = (num1001 + 1L);
                }

#line 109 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                {
#line 109 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1010 = (num1010 + 1L);
                }

#line 110 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                {
#line 110 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1011 = (num1011 + 1L);
                }

#line 111 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                {
#line 111 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1100 = (num1100 + 1L);
                }

#line 112 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                {
#line 112 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1101 = (num1101 + 1L);
                }

#line 113 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                {
#line 113 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1110 = (num1110 + 1L);
                }

#line 114 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                {
#line 114 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                    num1111 = (num1111 + 1L);
                }
            }

            // Q# simulator requires that after computation, qubits are left in 0 state (Class 73, 2'30"):
#line 120 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            Set.Apply((Result.Zero, qubits[0L]));
#line 121 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            Set.Apply((Result.Zero, qubits[1L]));
#line 122 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            Set.Apply((Result.Zero, qubits[2L]));
#line 123 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            Set.Apply((Result.Zero, qubits[3L]));
#line hidden
            Release.Apply(qubits);
            // Returning result:
#line 127 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            return (num0000, num0001, num0010, num0011, num0100, num0101, num0110, num0111, num1000, num1001, num1010, num1011, num1100, num1101, num1110, num1111);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Quantum.QB4.Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<QB4Run, QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>(QVoid.Instance);
        }
    }

    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.QB4.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (desired,q1) = __in;
#line 137 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            var current = M.Apply(q1);
            // Measures qubits (colapses it.)
#line 138 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
            if ((desired != current))
            {
#line 140 "C:\\Users\\joaoo\\Google Drive (joaoolive@gmail.com)\\Programação\\Quântica - Udemy\\QB4\\QB4\\QB4.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
                // Inverts value. NOT operation.
                ;
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }
}