import { View, Text } from 'react-native'
import { useGlobalContext } from '../context/GlobalProvider'
import React from 'react'
import { showCartProducts } from '../lib/appwrite'


const CartProduct = ({ nome, preco, handlePress }) => {

  return (
    <View className='mx-7 p-2 flex-row items-center space-x-6 '>
      <Text className='w-[175px] font-psemibold'>{nome}</Text>
      <Text className='bg-secondary-200 w-[90px] text-center text-white p-3 rounded-xl font-psemibold'>R${preco}</Text>
    </View>
  )
}

export default CartProduct