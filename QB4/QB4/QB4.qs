namespace Quantum.QB4
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

	operation QB4Run () : (Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int,Int)
    {
        body
        {
			// Counters for each combination.
			mutable num0000 = 0;
			mutable num0001 = 0;
			mutable num0010 = 0;
			mutable num0011 = 0;
			mutable num0100 = 0;
			mutable num0101 = 0;
			mutable num0110 = 0;
			mutable num0111 = 0;
			mutable num1000 = 0;
			mutable num1001 = 0;
			mutable num1010 = 0;
			mutable num1011 = 0;
			mutable num1100 = 0;
			mutable num1101 = 0;
			mutable num1110 = 0;
			mutable num1111 = 0;

            using (qubits = Qubit[4])
            {
                for (test in 1..10000) // 10 k iterations:
                {
                    Set (Zero, qubits[0]);
                    Set (Zero, qubits[1]);
					Set (Zero, qubits[2]);
					Set (Zero, qubits[3]);

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
					//Set (One, qubits[0]); // Always 1
                    //Set (One, qubits[1]); // Input & Pass through.
					//Set (Zero, qubits[2]); //Initialized to 0. Gets a result of the fanout from qubits[1]
					//CCNOT(qubits[0],qubits[1],qubits[2]);

					
					
					// Measuring qubits.
                    let res0 = M (qubits[0]);
					let res1 = M (qubits[1]);
					let res2 = M (qubits[2]);
					let res3 = M (qubits[3]);

					// Updating counters:
					if(res3 == Zero && res2 == Zero && res1 == Zero && res0 == Zero){set num0000 = num0000 + 1;}
					if(res3 == Zero && res2 == Zero && res1 == Zero && res0 == One ){set num0001 = num0001 + 1;}
					if(res3 == Zero && res2 == Zero && res1 == One  && res0 == Zero){set num0010 = num0010 + 1;}
					if(res3 == Zero && res2 == Zero && res1 == One  && res0 == One ){set num0011 = num0011 + 1;}
					if(res3 == Zero && res2 == One  && res1 == Zero && res0 == Zero){set num0100 = num0100 + 1;}
					if(res3 == Zero && res2 == One  && res1 == Zero && res0 == One ){set num0101 = num0101 + 1;}
					if(res3 == Zero && res2 == One  && res1 == One  && res0 == Zero){set num0110 = num0110 + 1;}
					if(res3 == Zero && res2 == One  && res1 == One  && res0 == One ){set num0111 = num0111 + 1;}
					if(res3 == One  && res2 == Zero && res1 == Zero && res0 == Zero){set num1000 = num1000 + 1;}
					if(res3 == One  && res2 == Zero && res1 == Zero && res0 == One ){set num1001 = num1001 + 1;}
					if(res3 == One  && res2 == Zero && res1 == One  && res0 == Zero){set num1010 = num1010 + 1;}
					if(res3 == One  && res2 == Zero && res1 == One  && res0 == One ){set num1011 = num1011 + 1;}
					if(res3 == One  && res2 == One  && res1 == Zero && res0 == Zero){set num1100 = num1100 + 1;}
					if(res3 == One  && res2 == One  && res1 == Zero && res0 == One ){set num1101 = num1101 + 1;}
					if(res3 == One  && res2 == One  && res1 == One  && res0 == Zero){set num1110 = num1110 + 1;}
					if(res3 == One  && res2 == One  && res1 == One  && res0 == One ){set num1111 = num1111 + 1;}
					
					
                }

				// Q# simulator requires that after computation, qubits are left in 0 state (Class 73, 2'30"):
                Set(Zero, qubits[0]);
				Set(Zero, qubits[1]);
				Set(Zero, qubits[2]);
				Set(Zero, qubits[3]);
            }
            
			// Returning result:
            return (num0000, num0001, num0010, num0011, num0100, num0101, num0110, num0111, 
					num1000, num1001, num1010, num1011, num1100, num1101, num1110, num1111);

        }
    }

	operation Set (desired: Result, q1: Qubit) : ()
    {
        body
        {
            let current = M(q1);	// Measures qubits (colapses it.)
            if (desired != current)
            {
                X(q1);				// Inverts value. NOT operation.
            }
        }
    }

}
