import { View, Text, Image, TouchableOpacity } from 'react-native'
import React from 'react'

const ProductCard = ({ nome, foto, preco }) => {
  return (
    <View className='flex-col p-6 py-10 mb-10 bg-secondary-200 rounded-xl mx-5'>

        <View>
            <TouchableOpacity
                className='w-full h-60 rounded-xl mt-5 relative justify-center items-center'
            >
                <Text className='text-xl text-white h-[90px]'>{nome}</Text>

                <Image
                    source={{ uri: foto }}
                    className='w-full h-full rounded-xl'
                    resizeMode='cover'
                />
            </TouchableOpacity>
        </View>
        <View className='h-[30px] justify-center mt-14 bg-white rounded px-2'>
            <Text className='text-xl text-black'>R${preco}</Text>
        </View>

    </View>
    
  )
}

export default ProductCard