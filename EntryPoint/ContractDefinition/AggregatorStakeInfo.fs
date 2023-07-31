namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type AggregatorStakeInfo() =
            [<Parameter("address", "aggregator", 1)>]
            member val public Aggregator = Unchecked.defaultof<string> with get, set
            [<Parameter("tuple", "stakeInfo", 2)>]
            member val public StakeInfo = Unchecked.defaultof<StakeInfo> with get, set
    

