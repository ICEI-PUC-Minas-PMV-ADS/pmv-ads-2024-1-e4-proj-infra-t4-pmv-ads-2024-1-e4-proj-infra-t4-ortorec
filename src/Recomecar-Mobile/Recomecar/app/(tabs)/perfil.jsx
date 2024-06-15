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
<SafeAreaView className=''>
<View className="">
<View className="">
 
          <View>
<Text className="">
              Perfil...
</Text>
</View>
 
          <View className="">
<TouchableOpacity className=""
            onPress={logout}
>
<Text className="">Sair</Text>
<Image
                source={icons.logout}
                className=""
                resizeMode="contain"
              />
</TouchableOpacity>
</View>
</View>
 
        <View className=''>
<Image
            source={{ uri: user?.avatar }}
            className=""
          />
<View className=''>
<Text className=' '>
<Text className="">Nome:</Text> {user?.username}
</Text>
<Text className=' '>
<Text className="">Email:</Text> {user?.email}
</Text>
<Text className=' '>
<Text className="">ID:</Text> {user?.$id}
</Text>
</View>
</View>
 
      </View>
</SafeAreaView>
  )
}
 
export default Perfil