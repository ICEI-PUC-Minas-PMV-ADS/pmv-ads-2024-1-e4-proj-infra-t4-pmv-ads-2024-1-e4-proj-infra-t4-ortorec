# Registro de Testes de Software

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

Teste e funcionalidade da API.BD no Swagger 

#### API_BD-swegger-GET
![swegger-GET](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/efcddf4ff35a4070ca1e8714dac2c6e4f049ba97/docs/img/API_BD-swegger-GET.png)
![swegger-GET2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/efcddf4ff35a4070ca1e8714dac2c6e4f049ba97/docs/img/API_BD-swegger-GET2.png)

#### API_BD-swegger-POST
![swegger-POST](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/efcddf4ff35a4070ca1e8714dac2c6e4f049ba97/docs/img/API_BD-swegger-POST.png)

#### API_BD-swegger-PUT
![swegger-POST](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/efcddf4ff35a4070ca1e8714dac2c6e4f049ba97/docs/img/API_BD-swegger-PUT.png)

#### API_BD-swegger-DELETE
![swegger-POST](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/efcddf4ff35a4070ca1e8714dac2c6e4f049ba97/docs/img/API_BD-Swegger-%20DELETE.png)

# Registro de testes do aplicativo Mobile

## Registro de Usuário

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/edbf11c1-5222-4851-be47-d213aa399cac

### Código de Registro
```
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
```

## Autenticação do Login

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/26c6de92-a4f3-45f5-92ed-7bd6a38a3511

### Código de Autenticação

```
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
```
## Teste Ponta a Ponta

### Mobile

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/0a7f764f-5eb0-4721-a4c8-a8fd767a21ba

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.
