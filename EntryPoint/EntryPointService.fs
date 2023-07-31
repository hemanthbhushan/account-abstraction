namespace AccountAbstraction.Contracts.EntryPoint

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts.ContractHandlers
open Nethereum.Contracts
open System.Threading
open AccountAbstraction.Contracts.EntryPoint.ContractDefinition


    type EntryPointService (web3: Web3, contractAddress: string) =
    
        member val Web3 = web3 with get
        member val ContractHandler = web3.Eth.GetContractHandler(contractAddress) with get
    
        static member DeployContractAndWaitForReceiptAsync(web3: Web3, entryPointDeployment: EntryPointDeployment, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> = 
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            web3.Eth.GetContractDeploymentHandler<EntryPointDeployment>().SendRequestAndWaitForReceiptAsync(entryPointDeployment, cancellationTokenSourceVal)
        
        static member DeployContractAsync(web3: Web3, entryPointDeployment: EntryPointDeployment): Task<string> =
            web3.Eth.GetContractDeploymentHandler<EntryPointDeployment>().SendRequestAsync(entryPointDeployment)
        
        static member DeployContractAndGetServiceAsync(web3: Web3, entryPointDeployment: EntryPointDeployment, ?cancellationTokenSource : CancellationTokenSource) = async {
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            let! receipt = EntryPointService.DeployContractAndWaitForReceiptAsync(web3, entryPointDeployment, cancellationTokenSourceVal) |> Async.AwaitTask
            return new EntryPointService(web3, receipt.ContractAddress);
            }
    
        member this.SIG_VALIDATION_FAILEDQueryAsync(sIG_VALIDATION_FAILEDFunction: SIG_VALIDATION_FAILEDFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<SIG_VALIDATION_FAILEDFunction, BigInteger>(sIG_VALIDATION_FAILEDFunction, blockParameterVal)
            
        member this.AddStakeRequestAsync(addStakeFunction: AddStakeFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(addStakeFunction);
        
        member this.AddStakeRequestAndWaitForReceiptAsync(addStakeFunction: AddStakeFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(addStakeFunction, cancellationTokenSourceVal);
        
        member this.BalanceOfQueryAsync(balanceOfFunction: BalanceOfFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameterVal)
            
        member this.DepositToRequestAsync(depositToFunction: DepositToFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(depositToFunction);
        
        member this.DepositToRequestAndWaitForReceiptAsync(depositToFunction: DepositToFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(depositToFunction, cancellationTokenSourceVal);
        
        member this.DepositsQueryAsync(depositsFunction: DepositsFunction, ?blockParameter: BlockParameter): Task<DepositsOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<DepositsFunction, DepositsOutputDTO>(depositsFunction, blockParameterVal)
            
        member this.GetDepositInfoQueryAsync(getDepositInfoFunction: GetDepositInfoFunction, ?blockParameter: BlockParameter): Task<GetDepositInfoOutputDTO> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryDeserializingToObjectAsync<GetDepositInfoFunction, GetDepositInfoOutputDTO>(getDepositInfoFunction, blockParameterVal)
            
        member this.GetNonceQueryAsync(getNonceFunction: GetNonceFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetNonceFunction, BigInteger>(getNonceFunction, blockParameterVal)
            
        member this.GetSenderAddressRequestAsync(getSenderAddressFunction: GetSenderAddressFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(getSenderAddressFunction);
        
        member this.GetSenderAddressRequestAndWaitForReceiptAsync(getSenderAddressFunction: GetSenderAddressFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(getSenderAddressFunction, cancellationTokenSourceVal);
        
        member this.GetUserOpHashQueryAsync(getUserOpHashFunction: GetUserOpHashFunction, ?blockParameter: BlockParameter): Task<byte[]> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<GetUserOpHashFunction, byte[]>(getUserOpHashFunction, blockParameterVal)
            
        member this.HandleAggregatedOpsRequestAsync(handleAggregatedOpsFunction: HandleAggregatedOpsFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(handleAggregatedOpsFunction);
        
        member this.HandleAggregatedOpsRequestAndWaitForReceiptAsync(handleAggregatedOpsFunction: HandleAggregatedOpsFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(handleAggregatedOpsFunction, cancellationTokenSourceVal);
        
        member this.HandleOpsRequestAsync(handleOpsFunction: HandleOpsFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(handleOpsFunction);
        
        member this.HandleOpsRequestAndWaitForReceiptAsync(handleOpsFunction: HandleOpsFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(handleOpsFunction, cancellationTokenSourceVal);
        
        member this.IncrementNonceRequestAsync(incrementNonceFunction: IncrementNonceFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(incrementNonceFunction);
        
        member this.IncrementNonceRequestAndWaitForReceiptAsync(incrementNonceFunction: IncrementNonceFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(incrementNonceFunction, cancellationTokenSourceVal);
        
        member this.InnerHandleOpRequestAsync(innerHandleOpFunction: InnerHandleOpFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(innerHandleOpFunction);
        
        member this.InnerHandleOpRequestAndWaitForReceiptAsync(innerHandleOpFunction: InnerHandleOpFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(innerHandleOpFunction, cancellationTokenSourceVal);
        
        member this.NonceSequenceNumberQueryAsync(nonceSequenceNumberFunction: NonceSequenceNumberFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<NonceSequenceNumberFunction, BigInteger>(nonceSequenceNumberFunction, blockParameterVal)
            
        member this.SimulateHandleOpRequestAsync(simulateHandleOpFunction: SimulateHandleOpFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(simulateHandleOpFunction);
        
        member this.SimulateHandleOpRequestAndWaitForReceiptAsync(simulateHandleOpFunction: SimulateHandleOpFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(simulateHandleOpFunction, cancellationTokenSourceVal);
        
        member this.SimulateValidationRequestAsync(simulateValidationFunction: SimulateValidationFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(simulateValidationFunction);
        
        member this.SimulateValidationRequestAndWaitForReceiptAsync(simulateValidationFunction: SimulateValidationFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(simulateValidationFunction, cancellationTokenSourceVal);
        
        member this.UnlockStakeRequestAsync(unlockStakeFunction: UnlockStakeFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(unlockStakeFunction);
        
        member this.UnlockStakeRequestAndWaitForReceiptAsync(unlockStakeFunction: UnlockStakeFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(unlockStakeFunction, cancellationTokenSourceVal);
        
        member this.WithdrawStakeRequestAsync(withdrawStakeFunction: WithdrawStakeFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(withdrawStakeFunction);
        
        member this.WithdrawStakeRequestAndWaitForReceiptAsync(withdrawStakeFunction: WithdrawStakeFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawStakeFunction, cancellationTokenSourceVal);
        
        member this.WithdrawToRequestAsync(withdrawToFunction: WithdrawToFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(withdrawToFunction);
        
        member this.WithdrawToRequestAndWaitForReceiptAsync(withdrawToFunction: WithdrawToFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawToFunction, cancellationTokenSourceVal);
        
    

