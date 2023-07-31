namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type ReturnInfo() =
            [<Parameter("uint256", "preOpGas", 1)>]
            member val public PreOpGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "prefund", 2)>]
            member val public Prefund = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bool", "sigFailed", 3)>]
            member val public SigFailed = Unchecked.defaultof<bool> with get, set
            [<Parameter("uint48", "validAfter", 4)>]
            member val public ValidAfter = Unchecked.defaultof<ulong> with get, set
            [<Parameter("uint48", "validUntil", 5)>]
            member val public ValidUntil = Unchecked.defaultof<ulong> with get, set
            [<Parameter("bytes", "paymasterContext", 6)>]
            member val public PaymasterContext = Unchecked.defaultof<byte[]> with get, set
    

