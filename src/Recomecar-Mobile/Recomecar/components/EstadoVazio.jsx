import { View, Text, Image } from 'react-native'
import React from 'react'

import { images } from "../constants"

const EstadoVazio = ({ title }) => {
  return (
    <View className='justify-center items-center px-4'>
        <Image source={images.vazio} className='w-[230px] h-[190px]' resizeMode='contain'/>
        <Text className="text-xl font-psemibold mt-2">
            {title}
        </Text>
    </View>
  )
}

export default EstadoVazio