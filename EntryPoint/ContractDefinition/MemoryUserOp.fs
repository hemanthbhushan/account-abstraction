namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type MemoryUserOp() =
            [<Parameter("address", "sender", 1)>]
            member val public Sender = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "nonce", 2)>]
            member val public Nonce = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "callGasLimit", 3)>]
            member val public CallGasLimit = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "verificationGasLimit", 4)>]
            member val public VerificationGasLimit = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "preVerificationGas", 5)>]
            member val public PreVerificationGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("address", "paymaster", 6)>]
            member val public Paymaster = Unchecked.defaultof<string> with get, set
            [<Parameter("uint256", "maxFeePerGas", 7)>]
            member val public MaxFeePerGas = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "maxPriorityFeePerGas", 8)>]
            member val public MaxPriorityFeePerGas = Unchecked.defaultof<BigInteger> with get, set
    

