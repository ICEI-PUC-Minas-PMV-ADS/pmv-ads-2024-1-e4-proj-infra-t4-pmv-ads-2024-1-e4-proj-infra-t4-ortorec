import { View, Text, Image, TouchableOpacity } from 'react-native'
import React from 'react'
import { router, Link } from 'expo-router'

const ProductCard = ({ nome, foto, preco, handlePress }) => {
  return (
    <View className='flex-col space-y-5  mb-10 bg-secondary-200 items-center rounded-xl mx-5'>
        
        <View>
            
            <TouchableOpacity
                onPress={handlePress}
                className='w-full rounded-xl mt-5 relative justify-center items-center'
            >
                

                <Text className='text-xl text-white mb-5 p-3'>{nome}</Text>

                <Image
                    source={{ uri: foto }}
                    className='w-[250px] h-[250px] rounded-xl'
                    resizeMode='cover'
                />
                
            </TouchableOpacity>
            
        </View>
        
        <View className=' justify-center  bg-white rounded px-2 mb-5'>
            <Text className='text-xl text-black'>R${preco}</Text>
        </View>
    </View>
    
  )
}

export default ProductCard