import { Text, View, ScrollView, StyleSheet, Image, Pressable, Button, TouchableHighlight, TouchableOpacity } from 'react-native'
import { Link, router, Redirect } from "expo-router";
import { StatusBar } from 'expo-status-bar';
import { SafeAreaView } from 'react-native-safe-area-context';

import { images } from '../constants';


import CustomButton from "../components/CustomButton";
import { useGlobalContext } from '../context/GlobalProvider';


export default function App(this: any) {

  const {isLoading, isLoggedIn } = useGlobalContext();

  if(!isLoading && isLoggedIn) return <Redirect href="/home" /> 

  return (
    <SafeAreaView className='bg-white h-full'>
      <ScrollView contentContainerStyle={{ height: '100%'}}>

        <View className='w-full justify-center items-center h-[85vh] px-4'>
          <Image
            className='w-80 h-80'
            resizeMode='contain'
            source={images.recomecarLogo}
          ></Image>
          
          <Text style={{ color: "black", fontSize: 22, textAlign: 'center', fontWeight: 'bold'}}> Sua loja de produtos ortopédicos de <Text style={{ color: '#fb00ff', fontWeight: 'bold'}}>confiança</Text> 
          </Text>

          <CustomButton
            title='Continuar com o Email'
            handlePress={() => router.push('/login')}
            containerStyles="w-full mt-10" textStyles={undefined} isLoading={undefined}          />

          <StatusBar backgroundColor='#861BE0' style='light' />

        </View>
      </ScrollView>
    </SafeAreaView>
  )
}







