import { PreventRemoveContext } from '@react-navigation/native';
import { Client, Account, ID, Avatars, Databases, Query, Permission, Role } from 'react-native-appwrite';

export const config = {

    //---------- Para banco de dados na nuvem

    endpoint: "https://cloud.appwrite.io/v1",
     platform: "com.pucvirtual.recomecar",
     projectId: "665619be002faa3e07ef",
     databaseId: "66561bdf003dc4b9dca2",
    userCollectionId: "66561c44002c41d228b5",
    produtoCollectionId: "66561c8b00357fa4457b",
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
      );
      
      console.log(newUser)
      return newUser;
    } catch (error) {
      throw new Error(error);
    }
  }

 // Login do usuário
 export const signIn = async (email, password) => {
     try {
        const session = await account.createEmailPasswordSession(email, password);

        console.log(session);

         return session;

     } catch (error) {
         throw new Error(error)
     }
 }
// Buscar usuário logado
 export const getAccount = async () => {
    try {
      const currentAccount = await account.get();

      return currentAccount;
  } catch (error) {
      // throw error;
      console.log("Usuário não encontrado", error);
  }
 }
// Pega os documentos do usuário atual
 export async function getCurrentUser() {
  try {
    const currentAccount = await getAccount();
    if (!currentAccount) throw Error;

    const currentUser = await databases.listDocuments(
      config.databaseId,
      config.userCollectionId,
      [Query.equal("accountid", currentAccount.$id)]
    );

    if (!currentUser) throw Error;

    return currentUser.documents[0];
  } catch (error) {
    console.log(error);
    return null;
  }
}
// Sai da conta
export async function signOut() {
  try {
    const session = await account.deleteSession("current");

    return session;
  } catch (error) {
    throw new Error(error);
  }
}
// Puxa os produtos do banco de dados
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
// Puxa os produtos mais recentes do banco de dados
export const getNewProductsPosts = async () => {
 
  try {

    const posts = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.orderDesc('$createdAt', Query.limit(7))]
    );


    return posts.documents;

  } catch (error) {
    throw new Error(error)
  }
}
// Puxa os produtos em destaque do banco de dados
export const getTrendingPosts = async () => {
 
  try {

    const posts = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.equal('destaque', [true])]
    );


    return posts.documents;

  } catch (error) {
    throw new Error(error)
  }
}
// Permite o usuário buscar por Produtos
export const searchPosts = async (query) => {
 
  try {

    const posts = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.search('nome', query)]
    );

    if (!posts) throw new Error("Something went wrong");

    return posts.documents;

  } catch (error) {
    throw new Error(error)
  }
}
// Puxa as informações de um produto específico
export const productInfo = async (id) => {
 
  try {

    const posts = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.search('$id', id)]
    );

    if (!posts) throw new Error("Something went wrong");

    return posts.documents;

  } catch (error) {
    throw new Error(error)
  }
}
// Adiciona um produto ao carrinho
export async function addToCart( productId, userId ) {
  try {

    const addCart = await databases.updateDocument(
      databaseId,
      produtoCollectionId,
      productId,
      {
        usuarios: userId,
      },
    );

    
    console.log(addToCart)
    return addCart;

  } catch (error) {
    throw new Error(error);
  }
}
// Puxa os produtos do carrinho do usuário atual
export async function showCartProducts( userId ) {

  try {
    const compras = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.equal("usuarios", [userId])]
    );

    return compras.documents;
    
  } catch (error) {
    throw new Error(error);
  }
}
// Retira itens do Carrinho
export async function removeCart( userId ) {
  try {

    const compras = await databases.listDocuments(
      databaseId,
      produtoCollectionId,
      [Query.equal("usuarios", [userId])]
    );

    const produto = compras.documents[0].$id;

    const removeCart = await databases.updateDocument(
      databaseId,
      produtoCollectionId,
      produto,
      {
        usuarios: '',
      }
        
    );
    
    console.log(removeCart)
    return removeCart;

  } catch (error) {
    throw new Error(error);
  }
}