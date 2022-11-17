# StreamJsonRpcTcp

Because .NetRemoting communication mechanism is canceled for. Net6, this project is used to test its alternative instance function. The test is used for interprocess communication (using StreamJsonRpc https://github.com/microsoft/vs-streamjsonrpc )。
Currently tested:

Basic architecture establishment between two processes (completed)

EventHandler delegate event (pass)

Custom delegate event (passed)

Call test without return value (passed)

Call with Task<Interface>return value type (failure, Has problems in Json deserialization)

Task<CustomObject>return value test with base class object. (failure, Has problems in Json deserialization)

The project JsonRpc_Server must be started first, and then the project JsonRpcClient can be started. Click the Send button for message transmission

2022-07-01 You can only use EventHandler to perform message transmission from Exe2 to Exe1, but you cannot use custom delegates to implement message transmission from Exe1 to Exe2.
