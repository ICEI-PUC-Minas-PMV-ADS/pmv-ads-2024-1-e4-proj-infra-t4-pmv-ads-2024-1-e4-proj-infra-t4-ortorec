import { Client, Account, ID, Avatars, Databases, Query } from 'react-native-appwrite';

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

const {
  endpoint,
  platform,
  projectId,
  databaseId,
  userCollectionId,
  produtoCollectionId,
  comprasCollectionId,
  storageId
} = config;

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
  
      // await signIn(email, password);
  
      const newUser = await databases.createDocument(
        config.databaseId,
        config.userCollectionId,
        ID.unique(),
        {
          accountid: newAccount.$id,
          email: email,
          username: username,
          avatar: avatarUrl,
        }
        [
          Permission.read(Role.any()),
          Permission.create(Role.any()),
          Permission.update(Role.any()),
          Permission.delete(Role.any())
        ]
      );
  
      return newUser;
    } catch (error) {
      throw new Error(error);
    }
  }

 // Login do usuário
 export const signIn = async (email, password) => {
     try {
        const session = await account.createEmailPasswordSession(email, password);

         return session;

     } catch (error) {
         throw new Error(error)
     }
 }

 export const getCurrentUser = async () => {
    try {
        const currentAccount = await account.get();

        if(!currentAccount) throw Error;

        const currentUser = await databases.listDocuments(
          config.databaseId,
          config.userCollectionId,
          [Query.equal('accountid', currentAccount.$id)]
        )

        if(!currentUser) throw Error;

        return currentUser.documents[0];

    } catch (error) {
        console.log(error);
    }
 }

 export const getAllPosts = async () => {
 
  try {

    const posts = await databases.listDocuments(
      databaseId,
      produtoCollectionId
    );


    return posts.documents;

  } catch (error) {
    throw new Error(error)
  }
}