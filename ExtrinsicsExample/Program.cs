using Ajuna.NetApi;
using Ajuna.NetApi.Model.Types;
using AjunaExample.NetApiExt.Generated;
using Schnorrkel.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrinsicsExample
{
    public class Program
    {
        private static string NodeUrl = "ws://127.0.0.1:9944";

        // Secret Key URI `//Alice` is account:
        // Secret seed:      0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a
        // Public key(hex):  0xd43593c715fdd31c61141abd04a99fd6822c8558854ccde39a5684e7a56da27d
        // Account ID:       0xd43593c715fdd31c61141abd04a99fd6822c8558854ccde39a5684e7a56da27d
        // SS58 Address:     5GrwvaEF5zXb26Fz9rcQpDWS57CtERHpNehXCPcNoHGKutQY
        public static MiniSecret MiniSecretAlice => new MiniSecret(
            Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"),
            ExpandMode.Ed25519);

        public static Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToBytes(),
            MiniSecretAlice.GetPair().Public.Key);

        public static async Task Main(string[] args)
        {
            var client = new SubstrateClientExt(new Uri(NodeUrl));

            Console.WriteLine($"Client Connection Status: {GetClientConnectionStatus(client)}");

            await client.ConnectAsync();

            Console.WriteLine(client.IsConnected ? "Client connected successfully" : "Failed to connect to node. Exiting...");

            if (!client.IsConnected)
                return;

            // Submit an extrinsic
            var numberValue = new Ajuna.NetApi.Model.Types.Primitive.U32();
            numberValue.Create(100000);

            var storeSomethingMethod = AjunaExample.NetApiExt.Generated.Storage.TemplateModuleCalls.DoSomething(numberValue);
            await client.Author.SubmitExtrinsicAsync(storeSomethingMethod, Alice, new Ajuna.NetApi.Model.Extrinsics.ChargeAssetTxPayment(0, 0), 128, CancellationToken.None);


            Console.ReadLine();
        }

        private static string GetClientConnectionStatus(SubstrateClientExt client)
        {
            return client.IsConnected ? "Connected" : "Not connected";

        }
    }
}
