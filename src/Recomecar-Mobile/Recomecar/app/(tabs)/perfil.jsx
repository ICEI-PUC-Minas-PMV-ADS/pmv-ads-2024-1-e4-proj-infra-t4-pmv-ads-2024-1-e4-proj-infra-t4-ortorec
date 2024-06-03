import { View, Text, SafeAreaView, Image, ScrollView } from 'react-native'
import { Link, router } from "expo-router";
import React from 'react'

import { images } from "../../constants"
import CustomButton from '@/components/CustomButton'

const Perfil = () => {
  return (
    <SafeAreaView>
      <ScrollView>
        <View className='mt-20 mb-10 px-8 space-y-6'>
          <View className="justify-between items-center flex-row mb-6">

            <View>
              <Text className="text-2xl font-psemibold">
                Perfil
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

          <Text className="text-lg">
            Nome: João da Silva
          </Text>

          <Text className="text-lg">
            CPF: 123.456.789-00
          </Text>

          <Text className="text-lg">
            Telefone: (31) 9 9999-9999
          </Text>

          <Text className="text-lg">
            E-mail:
          </Text>
          </View>
      </ScrollView>
    </SafeAreaView>
  )
}

export default Perfil