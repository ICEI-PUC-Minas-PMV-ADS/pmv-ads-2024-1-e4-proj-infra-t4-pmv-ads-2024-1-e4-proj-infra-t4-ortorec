import { View, Text, SafeAreaView, Image, ScrollView, SectionList } from 'react-native'
import { Link, router } from "expo-router";
import React from 'react'

import { images } from "../../constants"
import CustomButton from '@/components/CustomButton'

const Carrinho = () => {

  return (
    <SafeAreaView className='h-full '>

      <ScrollView>

        <View className='mt-20 mb-10 px-8 space-y-6'>
          <View className="justify-between items-center flex-row mb-6">

            <View>
              <Text className="text-2xl font-psemibold">
                Carrinho
              </Text>
            </View>

            <View className="mt-1.5">
              <Image
                source={images.recomecarLogoPequeno}
                className="w-20 h-20"
                resizeMode="contain"
              />
            </View>

          </View>

          {/* Tabela de compras */}
          <View className='border-2 rounded border-secondary'>

            <View className='flex-row justify-around bg-white'>

              <View className='flex-row space-x-5 bg-secondary w-full py-5 justify-around'>
                <Text className='text-white'>Produtos</Text>
                <Text className='text-white'>Quantidade</Text>
                <Text className='text-white'>Subtotal</Text>
              </View>

            </View>

            <View className='flex-collum justify-around bg-white'>

              <View className='flex-row space-x-5 w-full py-5 justify-around'>
                <Text>Produto 1</Text>
                <Text>1</Text>
                <Text>R$ 10,00</Text>
              </View>
              <View className='flex-row space-x-5 w-full py-5 justify-around'>
                <Text>Produto 2</Text>
                <Text>1</Text>
                <Text>R$ 10,00</Text>
              </View>
              <View className='flex-row space-x-5 w-full py-5 justify-around'>
                <Text>Produto 3</Text>
                <Text>1</Text>
                <Text>R$ 10,00</Text>
              </View>

            </View>

          </View>
        
          <View className='flex-row justify-between'>
            <Text className="text-xl font-psemibold">
              Total a pagar:
            </Text>
            <Text className="text-xl font-psemibold">
              R$30,00
            </Text>
          </View>

          <CustomButton
            title='Finalizar compra'
            containerStyles='mt-7' handlePress={undefined} textStyles={undefined} isLoading={undefined}          />

        </View>

      </ScrollView>

    </SafeAreaView>
  )
}

export default Carrinho