import { View, Text, StyleSheet, Pressable, ScrollView, Image, } from 'react-native'
import { Link, router } from "expo-router";
import { useState } from 'react'
import { SafeAreaView } from 'react-native-safe-area-context';
import {  handlePress } from 'react';

import { images } from '../../constants'
import FormField from '../../components/FormField';
import CustomButton from '../../components/CustomButton';

const Login = () => {
  const [form, setForm] = useState({
    email: '',
    senha: ''
  })

const [IsSubmitting, setIsSubmitting] = useState(false)

const submit = () => {
}

  return (
    <SafeAreaView>
      <ScrollView>
        <View className='w-full justify-center min-h-[90vh] px-4 my-6'>
          <Image source={images.recomecarLogo}
          resizeMode='contain' className='w-[150px] h-[150px]'
          >
          </Image>

          <Text className='text-xl font-semibold mt-5 font-psemibold'>Entre na sua conta Recomeçar</Text>
        
          <FormField
            title='Email'
            value={form.email}
            handleChangeText={(e) => setForm({ ...form, email: e })}
            otherStyles='mt-7'
            keyboardType='email-address'
          />
          <FormField
            title='Senha'
            value={form.senha}
            handleChangeText={(e) => setForm({ ...form, senha: e })}
            otherStyles='mt-7'
          />

          {/* Alterar para a função submit quando o backend estiver pronto */}
          <CustomButton
            title="Entrar"
            handlePress={() => router.push('/home')}
            //handlePress={submit}
            containerStyles='mt-9'
            isLoading={IsSubmitting}
          />

          <View className='justify-center pt-8 flex-row gap-2'>
            <Text className='text-base font-pmedium'>
              Não tem uma conta?
            </Text>

            <Link href="/registrar" className='text-lg font-psemibold text-secondary'>Registrar-se</Link>
          </View>
          
        </View>
      </ScrollView>
    </SafeAreaView>
    
  )
}

export default Login