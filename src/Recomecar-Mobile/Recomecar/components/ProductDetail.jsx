import { View, Text, Image, TouchableOpacity, ScrollView } from 'react-native'
import React from 'react'
import { router, Link } from 'expo-router'
import { SafeAreaView } from 'react-native-safe-area-context'

const ProductDetail = ({ nome, foto, preco, descricao, handlePress }) => {
  return (
    <SafeAreaView className='flex-1 rounded-xl items-center'>
        <Text className='text-xl bg-secondary-200 p-5 text-white h-[100px] rounded-xl'>{nome}</Text>

        <Image
            source={{ uri: foto }}
            className='w-[90%] h-[30%] rounded-xl justify-center items-center my-7'
            resizeMode='cover'
        />
            
        <Text className='text-lg p-2 font-psemibold'>Descrição do Produto...</Text>

        <Text className='text-lg p-5'>{descricao}</Text>

        <Text className='text-xl mt-5 mb-40'>R${preco}</Text>

        <TouchableOpacity
            onPress={handlePress}
            className='w-full h-60 rounded-xl mt-5 relative justify-center items-center'
        >

        </TouchableOpacity>
    </SafeAreaView>
  )
}

export default ProductDetail