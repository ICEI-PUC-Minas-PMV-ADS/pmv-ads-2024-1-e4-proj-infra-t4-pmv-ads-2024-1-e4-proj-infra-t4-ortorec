import { Text, View, ScrollView, StyleSheet, Image, Pressable, Button, TouchableHighlight, TouchableOpacity } from 'react-native'
import { Link, router } from "expo-router";
import { StatusBar } from 'expo-status-bar';
import { SafeAreaView } from 'react-native-safe-area-context';

import { images } from '../constants';
import { fontScale } from 'nativewind';


import CustomPress from '../components/CustomPress';

export default function App(this: any) {
  return (
    <SafeAreaView style={styles.container}>
      <ScrollView contentContainerStyle={{ height: '100%'}}>

        <View className='w-full justify-center items-center h-[85vh] px-4'>
          <Image
            className='w-80 h-80'
            resizeMode='contain'
            source={images.recomecarLogo}
          ></Image>
          
          <Text style={{ color: "black", fontSize: 22, textAlign: 'center', fontWeight: 'bold'}}> Sua loja de produtos ortopédicos de <Text style={{ color: '#fb00ff', fontWeight: 'bold'}}>confiança</Text> 
          </Text>

          <Pressable
          style={({ pressed }) => [
            styles.button,
            pressed && { backgroundColor: '#A168ED'},
          ]}
          onPress={() => router.push('/login')}
          >
            <Text style={{ color: 'white', fontWeight: 'bold'}}>Entrar</Text>
          </Pressable>

        </View>
      </ScrollView>
      <StatusBar backgroundColor='#A168ED' />
    </SafeAreaView>
  )
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'white',
    padding: 20,
    alignItems: 'center',

  },

  button: {
    alignItems: 'center',
    justifyContent: 'center',
    paddingVertical: 26,
    paddingHorizontal: 48,
    borderRadius: 10,
    elevation: 3,
    backgroundColor: '#fb00ff',
    borderColor: '#fb00ff',
    padding: 20,
    margin: 10,
    marginTop: 80,
  },

})




