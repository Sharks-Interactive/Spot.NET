- Update Google Protobufs by downloading, unzipping, and dragging them into Spot google/protobuf/. You can get the latest from here https://github.com/protocolbuffers/protobuf/tree/master/src/google/protobuf

- Now do the same for Boston Dynamics API protos except drag them into just the bosdyn/api/ folder, found here" https://github.com/boston-dynamics/spot-sdk/tree/master/bosdyn/api/bosdyn/api

- Now, open the .sln in Visual Studio, then add any new .proto files to the Protobuf include item Group

- Build the solution and the generated C# files will be spit out to the project directory, grab them and bring them over to the spot-sdk project

## Done.
