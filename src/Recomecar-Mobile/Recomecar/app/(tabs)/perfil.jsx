import { View, Text, FlatList, RefreshControl, Image, TouchableOpacity } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { router } from "expo-router";

import { signOut } from "../../lib/appwrite";

import { useGlobalContext } from "../../context/GlobalProvider";
import { images } from "../../constants"
import { icons } from '../../constants'


const Perfil = () => {

  const { user, setUser, setIsLoggedIn } = useGlobalContext();

  const logout = async () => {
    await signOut();
    setUser(null);
    setIsLoggedIn(false);

    router.replace("/login");
  };

  return (
    <SafeAreaView className='h-full'>
      <View className="my-6 px-6 space-y-6">
        <View className="justify-between items-center flex-row mb-6">

          <View>
            <Text className="font-pmedium text-xl">
              Perfil...
            </Text>
          </View>

          <View className="mt-1.5">
            <TouchableOpacity className="flex-row items-center space-x-2 "
            onPress={logout}
            >
              <Text className="text-red-600">Sair</Text>
              <Image
                source={icons.logout}
                className="w-8 h-8"
                resizeMode="contain"
                
              />
            </TouchableOpacity>
          </View>
        </View>

        <View className='rounded-2xl justify-center items-center p-3 space-y-7'>
          <Image
            source={{ uri: user?.avatar }}
            className="w-20 h-20 rounded-full bg-black"
          />
          <View className='rounded-2xl justify-center  p-3 space-y-5'>
            <Text className=' text-lg font-pregular mb-3'>
              <Text className="text-secondary">Nome:</Text> {user?.username}
            </Text>
            <Text className=' text-lg font-pregular mb-3'>
              <Text className="text-secondary">Email:</Text> {user?.email}
            </Text>
            <Text className=' text-lg font-pregular mb-3'>
              <Text className="text-secondary">ID:</Text> {user?.$id}
            </Text>
          </View>
          
        </View>

      </View>
    </SafeAreaView>
  )
}

export default Perfil