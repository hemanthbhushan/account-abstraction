namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type DepositInfo() =
            [<Parameter("uint112", "deposit", 1)>]
            member val public Deposit = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bool", "staked", 2)>]
            member val public Staked = Unchecked.defaultof<bool> with get, set
            [<Parameter("uint112", "stake", 3)>]
            member val public Stake = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint32", "unstakeDelaySec", 4)>]
            member val public UnstakeDelaySec = Unchecked.defaultof<uint> with get, set
            [<Parameter("uint48", "withdrawTime", 5)>]
            member val public WithdrawTime = Unchecked.defaultof<ulong> with get, set
    

