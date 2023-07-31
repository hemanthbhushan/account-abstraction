namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type UserOpInfo() =
            [<Parameter("tuple", "mUserOp", 1)>]
            member val public MUserOp = Unchecked.defaultof<MemoryUserOp> with get, set
            [<Parameter("bytes32", "userOpHash", 2)>]
            member val public UserOpHash = Unchecked.defaultof<byte[]> with get, set
            [<Parameter("uint256", "prefund", 3)>]
            member val public Prefund = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "contextOffset", 4)>]
            member val public ContextOffset = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "preOpGas", 5)>]
            member val public PreOpGas = Unchecked.defaultof<BigInteger> with get, set
    

