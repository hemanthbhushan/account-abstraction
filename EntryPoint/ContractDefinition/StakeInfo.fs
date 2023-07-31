namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type StakeInfo() =
            [<Parameter("uint256", "stake", 1)>]
            member val public Stake = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("uint256", "unstakeDelaySec", 2)>]
            member val public UnstakeDelaySec = Unchecked.defaultof<BigInteger> with get, set
    

