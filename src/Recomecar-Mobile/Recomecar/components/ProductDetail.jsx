import { View, Text, Image, TouchableOpacity, ScrollView, Alert } from 'react-native'
import React from 'react'
import { router, Link } from 'expo-router'
import { SafeAreaView } from 'react-native-safe-area-context'
import CustomButton from '../components/CustomButton';
import { addToCart } from '@/lib/appwrite';
import { useGlobalContext } from "../context/GlobalProvider";

const ProductDetail = ({ productId, nome, foto, preco, descricao, handlePress }) => {

  
  const { user, setUser, setIsLogged } = useGlobalContext();

  const userId = user?.$id;

  return (
    <SafeAreaView className='flex-1  rounded-xl items-center'>
        <Text className='text-xl bg-secondary-200 p-5 mx-2 text-white  rounded-xl'>{nome}</Text>

        <Image
            source={{ uri: foto }}
            className='w-[300px] h-[300px] rounded-xl justify-center items-center my-7'
            resizeMode='cover'
        />
        
        <Text className='text-xl p-2 mb-4 font-psemibold bg-secondary-200 text-white rounded-xl'>R${preco}</Text>

        <Text className='text-lg p-2 font-psemibold'>Descrição do Produto...</Text>

        <Text className='text-lg p-5 mb-10'>{descricao}</Text>

        <View className=' flex-row justify-center items-center space-x-4 mb-10'>
          <CustomButton
                title="Adicionar ao Carrinho"
                containerStyles='p-2'
                textStyles='text-base'
                handlePress={() => {
                  Alert.alert('Adicionar produto ao carrinho?', 'Deseja adicionar este produto ao carrinho?', [
                    {
                      text: 'Cancelar',
                      onPress: () => console.log('Cancel Pressed'),
                      style: 'cancel'
                    },
                    {
                      text: 'Adicionar',
                      onPress: () => { addToCart(productId, userId), Alert.alert('Produto adicionado ao carrinho!', 'Deseja continuar comprando? Ou ir para o carrinho?', [
                        {
                          text: 'Continuar',
                          onPress: () => console.log('Cancel Pressed'),
                          style: 'cancel'
                        },
                        {
                          text: 'Carrinho',
                          onPress: () => router.push({ pathname: `(tabs)/carrinho`})
                        }
                      ])}
                    }
                  ]);
                }}
              />

          <Text className='text-xl border-2 border-secondary p-3 rounded-xl'>R${preco}</Text>
        </View>
        
    </SafeAreaView>
  )
}

export default ProductDetail