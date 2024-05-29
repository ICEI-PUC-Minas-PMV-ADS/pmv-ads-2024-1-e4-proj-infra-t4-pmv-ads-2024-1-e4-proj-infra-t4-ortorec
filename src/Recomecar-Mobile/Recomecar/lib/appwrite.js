import { Client, Account, ID } from 'react-native-appwrite';

export const config = {
    endpoint: "https://cloud.appwrite.io/v1",
     platform: "com.pucvirtual.recomecar",
     projectId: "665619be002faa3e07ef",
     databaseId: "66561bdf003dc4b9dca2",
    userCollectionId: "66561c44002c41d228b5",
    produtoCollectionId: "66561c8b00357fa4457b",
    comprasCollectionId: "66561eeb0025396a28cb",
    storageId: "6656206000240bcf7db2",
}

// Init your React Native SDK
 const client = new Client();

 client
     .setEndpoint(config.endpoint) // Your Appwrite Endpoint
     .setProject(config.projectId) // Your project ID
     .setPlatform(config.platform) // Your application ID or bundle ID.


     const account = new Account(client);

// Registrar usuário
 export const createUser = () => {
     account.create(ID.unique(), 'me@example.com', '94738888', 'Jane Doe')
     .then(function (response) {
         console.log(response);
     }, function (error) {
         console.log(error);
     });
 }

