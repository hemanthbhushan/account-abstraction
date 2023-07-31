namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type UserOperation() =
            [<Parameter("address", "sender", 1)>]
            member val public Sender = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "nonce", 2)>]
            member val public Nonce = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bytes", "initCode", 3)>]
            member val public InitCode = Unchecked.defaultof<byte[]> with get, set
            [<Parameter("bytes", "callData", 4)>]
            member val public CallData = Unchecked.defaultof<byte[]> with get, set
            [<Parameter("uint256", "callGasLimit", 5)>]
            member val public CallGasLimit = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "verificationGasLimit", 6)>]
            member val public VerificationGasLimit = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "preVerificationGas", 7)>]
            member val public PreVerificationGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "maxFeePerGas", 8)>]
            member val public MaxFeePerGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "maxPriorityFeePerGas", 9)>]
            member val public MaxPriorityFeePerGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bytes", "paymasterAndData", 10)>]
            member val public PaymasterAndData = Unchecked.defaultof<byte[]> with get, set
            [<Parameter("bytes", "signature", 11)>]
            member val public Signature = Unchecked.defaultof<byte[]> with get, set
    

