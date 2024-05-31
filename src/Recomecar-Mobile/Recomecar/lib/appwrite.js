import { Client, Account, ID, Avatars, Databases } from 'react-native-appwrite';

export const config = {

    //---------- Para banco de dados na nuvem

    endpoint: "https://cloud.appwrite.io/v1",
     platform: "com.pucvirtual.recomecar",
     projectId: "665619be002faa3e07ef",
     databaseId: "66561bdf003dc4b9dca2",
    userCollectionId: "66561c44002c41d228b5",
    produtoCollectionId: "66561c8b00357fa4457b",
    comprasCollectionId: "66561eeb0025396a28cb",
    storageId: "6656206000240bcf7db2",

    // ---------- Para banco de dados local
    // endpoint: "http://localhost/v1",
    // platform: "com.pucvirtual.recomecar",
    // projectId: "665888f300154937a1a9",
    // databaseId: "6658892f000406613450",
    // userCollectionId: "665889370014e8a338a0",
    // produtoCollectionId: "665889a8000f424d229a",
    // comprasCollectionId: "66588a0e002396e61a1e",
    // storageId: "66588eb700074496f596",
}

// Init your React Native SDK
 const client = new Client();

    //---------- Para banco de dados na nuvem

client
     .setEndpoint(config.endpoint) // Your Appwrite Endpoint
     .setProject(config.projectId) // Your project ID
     .setPlatform(config.platform) // Your application ID or bundle ID.

     const account = new Account(client);
     const avatars = new Avatars(client);
     const databases = new Databases(client);

 // Registrar usuário
 export async function createUser(email, password, username) {
    try {
      const newAccount = await account.create(
        ID.unique(),
        email,
        password,
        username
      );
  
      if (!newAccount) throw Error;
  
      const avatarUrl = avatars.getInitials(username);
  
      await signIn(email, password);
  
      const newUser = await databases.createDocument(
        appwriteConfig.databaseId,
        appwriteConfig.userCollectionId,
        ID.unique(),
        {
          accountId: newAccount.$id,
          email: email,
          username: username,
          avatar: avatarUrl,
        }
      );
  
      return newUser;
    } catch (error) {
      throw new Error(error);
    }
  }

 // Login do usuário
 export async function signIn(email, password) {
     try {
        const session = await account.createEmailPasswordSession(email, password);

         return session;

     } catch (error) {
         throw new Error(error)
     }
 }
