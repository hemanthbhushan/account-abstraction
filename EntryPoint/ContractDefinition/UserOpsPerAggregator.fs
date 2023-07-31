namespace AccountAbstraction.Contracts.EntryPoint.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes

    type UserOpsPerAggregator() =
            [<Parameter("tuple[]", "userOps", 1)>]
            member val public UserOps = Unchecked.defaultof<List<UserOperation>> with get, set
            [<Parameter("address", "aggregator", 2)>]
            member val public Aggregator = Unchecked.defaultof<string> with get, set
            [<Parameter("bytes", "signature", 3)>]
            member val public Signature = Unchecked.defaultof<byte[]> with get, set
    

